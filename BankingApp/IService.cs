namespace services
{
    // crud operaciebis tvis 
    // All services will implement this interface
    public interface IService<T>
    {
        // Add a new item to the system
        void Add(T item);
        
        // Get all items of type T
        List<T> GetAll();
        
        // Get a specific item by its ID
        T GetById(Guid id);
        
        // Update an existing item
        void Update(T item);
        
        // Delete an item from the system
        void Delete(T item);
    }
}