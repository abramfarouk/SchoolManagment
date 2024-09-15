namespace SchoolManagment.Data.AppMetaData
{
    public static class Router
    {

        public const string Root = "Api";
        public const string Version = "v1";
        public const string Rule = Root + "/" + Version + "/";


        public static class StudentRouting
        {
            public const string Prefix = Rule + "Student/";
            public const string List = Prefix + "List";
            public const string GetById = Prefix + "{id:int}";
            public const string GetByName = Prefix + "{name:Alpha}";
            public const string Create = Prefix + "Create";
            public const string Update = Prefix + "Update";
            public const string Delete = Prefix + "Delete";


        }
        public static class AccountRouting
        {
            public const string Prefix = Rule + "Account/";
            public const string List = Prefix + "List";
            public const string GetById = Prefix + "{id:int}";
            public const string GetByName = Prefix + "{name:Alpha}";
            public const string Create = Prefix + "Create";
            public const string Update = Prefix + "Update";
            public const string Delete = Prefix + "Delete";


        }

    }
}
