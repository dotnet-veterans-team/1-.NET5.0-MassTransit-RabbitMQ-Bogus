namespace WebApiPayments.Models
{
    public class RabbitMqSettings
    {
        public const string RabbitMqRootUri = "rabbitmq://localhost";
        public const string RabbitMqUri = "rabbitmq://localhost/PaymentsQueue";
        public const string UserName = "guest";
        public const string Password = "guest";
        public const string NotificationServiceQueue = "notification.service";
    }
}
