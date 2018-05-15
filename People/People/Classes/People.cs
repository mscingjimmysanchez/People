/// <summary>
/// People's namespace.
/// </summary>
namespace People
{
    /// <summary>
    /// Class to manage people.
    /// </summary>
    public class People
    {
        /// <summary>
        /// Person's id.
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Person's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Person's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Person's current role.
        /// </summary>
        public string CurrentRole { get; set; }

        /// <summary>
        /// Person's country.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Person's industry.
        /// </summary>
        public string Industry { get; set; }

        /// <summary>
        /// Person's number of recommendations.
        /// </summary>
        public int NumberOfRecommendations { get; set; }

        /// <summary>
        /// Person's number of connections.
        /// </summary>
        public int NumberOfConnections { get; set; }

        /// <summary>
        /// Class' empty constructor.
        /// </summary>
        public People()
        {

        }
    }
}
