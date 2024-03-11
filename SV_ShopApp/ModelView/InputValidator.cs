
namespace SV_ShopApp.ModelView
{
    public class InputValidator
    {
        public bool checkInput(String text)
        {
            bool isOkay = false;

            if (checkLength(text) && checkIsInt(text))
            {
                isOkay = true;
            }

            return isOkay;
        }

        private bool checkLength(String text)
        {
            bool isOkay = false;

            if (text.Length==4)
            {
                isOkay = true;
            }

            return isOkay;

        }

        private bool checkIsInt(String text)
        {
            bool isInt = false;

            try
            {
                int testInt = Convert.ToInt32(text);
                isInt = true;
            }
            catch (Exception)
            {

            }

            return isInt;
        }

    }

}
