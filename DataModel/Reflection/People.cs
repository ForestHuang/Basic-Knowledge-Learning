namespace SURE.DataEntity.Reflection
{
    /// <summary>
    /// People 人,用来测试反射
    /// </summary>
    public class People
    {
        /// <summary>
        /// _id
        /// </summary>
        public string _id { get; set; }

        private int peopleId;
        /// <summary>
        /// PeopleId
        /// </summary>
        public int PeopleId
        {
            get { return peopleId; }
            set { peopleId = value; }
        }

        private string peopleName;
        /// <summary>
        /// 名称
        /// </summary>
        public string PeopleName
        {
            get { return peopleName; }
            set { peopleName = value; }
        }

        /// <summary>
        /// 地址
        /// </summary>
        public string PeopleAddress { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int PeopleAge { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string PeopleSex { get; set; }


        //----------------------Public Method------------------------
        public static string HelloMethodParam(string userName)
        {
            return $"My name is {userName}";
        }

        public static string HelloMethod()
        {
            return $"My name is senlin.huang";
        }

        //---------------------Private Method----------------------
        private static string HelloMethodPrivate(string userName)
        {
            return $"My name is {userName}";
        }

    }
}
