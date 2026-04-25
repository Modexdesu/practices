using models;
using data;

namespace services
{
    // clientebis operaciebi
    // Implements the IService interface with Client type
    public class ClientService : IService<Client>
    {
        // Add a new client to the system
        public void Add(Client client)
        {
            Database.Clients.Add(client);
        }

        // Get all clients from the system
        public List<Client> GetAll()
        {
            return Database.Clients;
        }

        // Find a specific client by their ID
        public Client GetById(Guid id)
        {
            return Database.Clients.FirstOrDefault(c => c.ID == id);
        }

        // Update an existing client's information
        public void Update(Client client)
        {
            var existingClient = GetById(client.ID);
            if (existingClient != null)
            {
                existingClient.Name = client.Name;
                existingClient.LastName = client.LastName;
                existingClient.PhoneNumber = client.PhoneNumber;
            }
        }

        // Remove a client from the system
        public void Delete(Client client)
        {
            Database.Clients.Remove(client);
        }
    }
}