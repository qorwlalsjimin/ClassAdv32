using System;

namespace ClassAdv32
{
    internal class Box
    {

/*        // 필드(매개변수) 방식의 getter
        private int width;

        private int height;

        public Box(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int GetWidth()
        {
            return width;
        }*/

        private int width;
        public int Width { 
            get { return width; }
            set
            {
                if (value < 0)
                {
                    throw (new Exception("width는 양수여야 합니다."));
                }
                width = value;
            }
        } //속성은 대문자

        private int height;
        public int Height {
            get { return height;  }
            set
            {
                if (value < 0)
                {
                    throw (new Exception("height는 양수여야 합니다."));
                }
                else Console.WriteLine("???ㅠㅠ"+value);
                height = value;
            }
        }

        public Box(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int GetArea()
        {
            return this.Width * this.Height;
        }

    }
}