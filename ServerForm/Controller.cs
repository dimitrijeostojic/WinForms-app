using Common.Domain;
using ServerForm.SystemOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Controller
    {
        #region singleton
        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Controller();
                }
                return instance;
            }
        }
        private Controller()
        {

        }

        #endregion

        public User CurrentUser { get; set; }
        public User Login(User user)
        {
            LoginSO loginUser = new LoginSO(user);
            loginUser.ExecuteTemplate();
            return loginUser.Result;
        }

        public void SaveUser(User user)
        {
            SaveUserSO registerUser = new SaveUserSO(user);
            registerUser.ExecuteTemplate();
        }

        public List<Plane> GetPlanes()
        {
            GetPlanesSO getPlanes = new GetPlanesSO();
            getPlanes.ExecuteTemplate();
            return getPlanes.Result;
        }

        public void CreateFlight(Flight flight)
        {
            SaveFlightSO createFlight = new SaveFlightSO(flight);
            createFlight.ExecuteTemplate();
        }

        public List<Flight> GetMyFlights(User user)
        {
            GetMyFlightsSO getMyFlights = new GetMyFlightsSO(user);
            getMyFlights.ExecuteTemplate();
            return getMyFlights.Result;
        }

        public List<Airport> GetAllAirports()
        {
            GetAllDestinationsSO getAllAirports = new GetAllDestinationsSO();
            getAllAirports.ExecuteTemplate();
            return getAllAirports.Result;
        }

        public bool UpdateFlight(Flight flight)
        {
            UpdateFlightSO updateFlight = new UpdateFlightSO(flight);
            updateFlight.ExecuteTemplate();
            return updateFlight.Result;
        }

        public void DeleteFlight(Flight flight)
        {
            DeleteFlightSO deleteFlight = new DeleteFlightSO(flight);
            deleteFlight.ExecuteTemplate();
        }

        public object GetAllFlights()
        {
            GetAllFlightsSO getAllFlights = new GetAllFlightsSO();
            getAllFlights.ExecuteTemplate();
            return getAllFlights.Result;
        }

        public object GetAllUsers(User user)
        {
            GetAllUsersSO getAllUsers = new GetAllUsersSO(user);
            getAllUsers.ExecuteTemplate();
            return getAllUsers.Result;
        }

        public object UpdateUser(User user)
        {
            UpdateUserSO updateUser = new UpdateUserSO(user);
            updateUser.ExecuteTemplate();
            return updateUser.Result;
        }

        public object Search(object argument, object user, string searchType)
        {
            SearchSO search = new SearchSO(argument, user, searchType);
            search.ExecuteTemplate();
            return search.Result;
        }

        internal object FindFlightByID(object argument)
        {
            FindFlightByIDSO findFlightByID = new FindFlightByIDSO(argument);
            findFlightByID.ExecuteTemplate();
            return findFlightByID.Result;
        }

        internal object FindUserByID(object argument)
        {
            FindUserByIDSO findUserByID = new FindUserByIDSO(argument);
            findUserByID.ExecuteTemplate();
            return findUserByID.Result;
        }

        internal object GetReservationsByID(object argument)
        {
            GetAllReservationsSO getReservationsByID = new GetAllReservationsSO(argument);
            getReservationsByID.ExecuteTemplate();
            return getReservationsByID.Result;
        }

        internal void SaveAllReservations(object argument)
        {
            SaveAllReservationsSO saveAllReservation = new SaveAllReservationsSO(argument);
            saveAllReservation.ExecuteTemplate();
        }

        internal void DeleteReservation(object argument)
        {
            DeleteReservationSO deleteReservation = new DeleteReservationSO(argument);
            deleteReservation.ExecuteTemplate();
        }

        internal void UpdateReservations(object argument)
        {
            UpdateAllReservationsSO updateAllReservations = new UpdateAllReservationsSO(argument);
            updateAllReservations.ExecuteTemplate();
        }

        internal object GetReservationByID(object argument)
        {
            FindReservationByIDSO getReservationByID = new FindReservationByIDSO(argument);
            getReservationByID.ExecuteTemplate();
            return getReservationByID.Result;
        }
    }
}
