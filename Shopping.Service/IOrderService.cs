namespace Shopping.Service
{
    using System.ServiceModel;

    using Shopping.Service.Messages;

    [ServiceContract]
    public interface IOrderService
    {

        [OperationContract]
        void Order(OrderRequestMessage request);
    }
}
