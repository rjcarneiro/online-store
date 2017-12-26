namespace Domain.Model
{
    public abstract class Entity<TIdentifierType>
    {
        public Entity(TIdentifierType id)
        {
            this.Id = id;
        }

        public TIdentifierType Id { get; }
    }
}
