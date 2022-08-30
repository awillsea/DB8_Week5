namespace class_review
{
    public class Misc
    {
        public static bool CheckRange(int x)
        {
            if (x >= 10 && x <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // lets write a method that  takes an integer
        // and returns :
        //      -1 if the int is negative
        //       0 is the int is 0
        //       1 if the int is positive

        public static int posNeg(int x)
        {
            return Math.Sign(x);



        }


    }
}
