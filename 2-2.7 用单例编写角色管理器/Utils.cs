using System;
using System.Collections.Generic;
using System.Text;

namespace _2_2._7_用单例编写角色管理器
{
    class Utils
    {
        private static Utils instance = null;

        public static Utils Instance
        {
            get
            {
                if (instance == null)
                { instance = new Utils(); }
                return instance;
            }

        }

        private Random random = new Random();

        public int RandomNum(int a, int b)
        { return random.Next(a, b); }

    }
}
