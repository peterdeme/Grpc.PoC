namespace ECommerce.Contracts.Configuration
{
    public static class SharedConstants
    {
        public static class GRPC
        {
            public const int UserServiceBackendPortNumber = 23456;
            public const int ProductServiceBackendPortNumber = 23457;
        }

        public static class Kestrel
        {
            public const int UserServiceKestrelPortNumber = 22456;
            public const int ProductServiceKestrelPortNumber = 22457;
        }
    }
}
