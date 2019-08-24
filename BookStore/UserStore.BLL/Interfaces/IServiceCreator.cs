namespace UserStore.BLL.Interfaces
{
    public interface IServiceCreator
    {
        IUserService CreateUserService();
		IDiscountCardService CreateDiscountCardService();
    }
}
