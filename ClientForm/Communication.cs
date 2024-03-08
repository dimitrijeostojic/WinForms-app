using Common;
using Common.Domain;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Common
{
    public class Communication
    {
        private Socket socket;
        private Receiver receiver;
        private Sender sender;
        #region singleton
        private static Communication instance;
        public static Communication Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Communication();
                }
                return instance;
            }
        }
        private Communication()
        {

        }
        #endregion

        public void Connect()
        {
            try
            {
                if (socket == null || !socket.Connected)
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket.Connect("127.0.0.1", 9999);
                    receiver = new Receiver(socket);
                    sender = new Sender(socket);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Izmenite podatke o bazi");
            }
        }

        public void Disconnect()
        {
            try
            {
                Request req = new Request
                {
                    Operacija = Operations.Kraj
                };
                sender.Send(req);
                socket.Close();
                socket = null;
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void Send(Request request)
        {
            sender.Send(request);
        }

        public object Receive()
        {
            return receiver.Receive();
        }

        public List<Plane> GetAllPlanes()
        {
            Request req = new Request
            {
                Operacija = Operations.GetPlanes
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return (List<Plane>)res.Result;
        }

        public List<Flight> GetMyFlights(User user)
        {
            Request req = new Request
            {
                Operacija = Operations.GetMyFlights,
                Argument = user
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return (List<Flight>)res.Result;
        }

        public List<Airport> GetAllAirports()
        {
            Request req = new Request
            {
                Operacija = Operations.GetAllAirports,
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return (List<Airport>)res.Result;
        }

        public Response UpdateFlight(Flight flight)
        {
            Request req = new Request
            {
                Operacija = Operations.UpdateFlight,
                Argument = flight
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return res;
        }

        public Response DeleteFlight(Flight f)
        {
            Request req = new Request
            {
                Operacija = Operations.DeleteFlight,
                Argument = f
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return res;
        }

        public List<Flight> GetAllFlights()
        {
            Request req = new Request
            {
                Operacija = Operations.GetAllFlights
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return (List<Flight>)res.Result;
        }

        public List<User> GetAllUsers(User user)
        {
            Request req = new Request
            {
                Operacija = Operations.GetAllUsers,
                Argument = user
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return (List<User>)res.Result;
        }

        public Response UpdateUser(User user)
        {
            Request req = new Request
            {
                Operacija = Operations.UpdateUser,
                Argument = user
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return res;
        }

        public Response Login(User user)
        {
            Request req = new Request()
            {
                Operacija = Operations.Login,
                Argument = user
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return res;
        }

        internal Response Register(User user)
        {
            Request req = new Request()
            {
                Operacija = Operations.Registration,
                Argument = user
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return res;
        }

        internal Response FindFlightById(int flightID)
        {
            Request req = new Request()
            {
                Operacija = Operations.FindFlightByID,
                Argument = flightID,
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return res;
        }

        internal Response FindUserByID(string jmbg)
        {
            Request req = new Request()
            {
                Operacija = Operations.FindUserByID,
                Argument = jmbg,
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return res;
        }

        public Response AddReservation(Reservation reservation)
        {
            Request req = new Request()
            {
                Operacija = Operations.AddReservation,
                Argument = reservation
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return res;
        }

        public List<Reservation> GetReservationsByID(User user)
        {
            Request req = new Request()
            {
                Operacija = Operations.GetReservations,
                Argument = user
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return (List<Reservation>)res.Result;
        }

        internal Response SaveAllReservations(List<Reservation> reservations)
        {
            Request req = new Request()
            {
                Operacija = Operations.SaveAllReservations,
                Argument = reservations
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return res;
        }

        internal Response SaveUser(User user)
        {
            Request req = new Request()
            {
                Operacija = Operations.Registration,
                Argument = user
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return res;
        }

        internal IList<Reservation> GetAllReservations(User user)
        {
            Request req = new Request()
            {
                Operacija = Operations.GetReservations,
                Argument = user
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return (IList<Reservation>)res;
        }

        internal Response DeleteReservation(Reservation r)
        {
            Request req = new Request
            {
                Operacija = Operations.DeleteReservation,
                Argument = r
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return res;
        }

        internal Response UpdateAllReservations(List<Reservation> reservations)
        {
            Request req = new Request
            {
                Operacija = Operations.UpdateAllReservations,
                Argument = reservations
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return res;
        }

        internal Response CreateFlight(Flight flight)
        {
            Request req = new Request()
            {
                Operacija = Operations.SaveFlight,
                Argument = flight
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return res;
        }

        internal Response Search(string input, User user, string type)
        {
            Request req = new Request()
            {
                Operacija = Operations.Search,
                Argument = input,
                User = user,
                SearchType = type
            };
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            return res;
        }

        internal Response UpdateReservation(Reservation res)
        {
            Request req = new Request
            {
                Operacija = Operations.UpdateReservation,
                Argument = res
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response GetReservationByID(Reservation reservation)
        {
            Request req = new Request
            {
                Operacija = Operations.GetReservationByID,
                Argument = reservation
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }
    }
}
