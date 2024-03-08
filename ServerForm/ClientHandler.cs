using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ClientHandler
    {
        private Socket socket;
        private Sender sender;
        private Receiver receiver;
        private bool kraj = false;

        public ClientHandler(Socket socket)
        {
            sender = new Sender(socket);
            this.socket = socket;
            receiver = new Receiver(socket);
        }



        public void HandleRequest()
        {
            try
            {
                while (!kraj)
                {
                    Request req = (Request)receiver.Receive();
                    Response res = ProcessRequest(req);
                    sender.Send(res);
                }
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private Response ProcessRequest(Request req)
        {
            Response res = new Response();
            try
            {
                switch (req.Operacija)
                {
                    case Operations.Login:
                        res.Result = Controller.Instance.Login((User)req.Argument);
                        break;
                    case Operations.Registration:
                        Controller.Instance.SaveUser((User)req.Argument);
                        break;
                    case Operations.SaveFlight:
                        Controller.Instance.CreateFlight((Flight)req.Argument);
                        break;
                    case Operations.GetAllFlights:
                        res.Result = Controller.Instance.GetAllFlights();
                        break;
                    case Operations.Search:
                        res.Result = Controller.Instance.Search(req.Argument, req.User, req.SearchType);
                        break;
                    case Operations.FindFlightByID:
                        res.Result = Controller.Instance.FindFlightByID(req.Argument);
                        break;
                    case Operations.UpdateFlight:
                        res.Result = Controller.Instance.UpdateFlight((Flight)req.Argument);
                        break;
                    case Operations.DeleteFlight:
                        Controller.Instance.DeleteFlight((Flight)req.Argument);
                        break;
                    case Operations.GetAllUsers:
                        res.Result = Controller.Instance.GetAllUsers((User)req.Argument);
                        break;
                    case Operations.FindUserByID:
                        res.Result = Controller.Instance.FindUserByID(req.Argument);
                        break;
                    case Operations.UpdateUser:
                        res.Result = Controller.Instance.UpdateUser((User)req.Argument);
                        break;
                    case Operations.SaveAllReservations:
                        Controller.Instance.SaveAllReservations(req.Argument);
                        break;
                    case Operations.GetAllAirports:
                        res.Result = Controller.Instance.GetAllAirports();
                        break;
                    case Operations.GetReservations:
                        res.Result = Controller.Instance.GetReservationsByID(req.Argument);
                        break;
                    case Operations.GetReservationByID:
                        res.Result = Controller.Instance.GetReservationByID(req.Argument);
                        break;
                    case Operations.UpdateAllReservations:
                        Controller.Instance.UpdateReservations(req.Argument);
                        break;
                    case Operations.GetMyFlights:
                        res.Result = Controller.Instance.GetMyFlights((User)req.Argument);
                        break;
                    case Operations.DeleteReservation:
                        Controller.Instance.DeleteReservation(req.Argument);
                        break;
                    case Operations.GetPlanes:
                        res.Result = Controller.Instance.GetPlanes();
                        break;
                    case Operations.Kraj:
                        socket.Shutdown(SocketShutdown.Both);
                        socket.Close();
                        kraj = true;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                res.Exception = ex;
                Debug.WriteLine(ex.Message);
            }
            return res;
        }
    }
}
