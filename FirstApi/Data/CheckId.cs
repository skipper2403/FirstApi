namespace FirstApi.Data
{
    public class CheckId
    {
        private readonly FirstAPIDbContext dbContext;
        public CheckId(FirstAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //creating constructor
        public async Task<bool> CheckIdInDatabase(Guid id)
        {
            var contact = await dbContext.Contacts.FindAsync(id);
            if(contact == null)
                return false;

            return true;
        }
    }
}
