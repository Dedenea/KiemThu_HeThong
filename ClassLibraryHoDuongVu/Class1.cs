using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryHoDuongVu
{
    public class Class1
    {
        public String HowToGrade(float exam, float course)
        {
            if ((exam < 0.0) || (exam > 100.0) || (course < 0.0) || (course > 100.00))
                return "";
            else
            {
                if ((exam < 50.0) || (course < 50.0))
                    return "Fail";
                else if (exam < 60)
                    return "C";
                else
                {
                    float averange = (exam + course) / 2.0f;
                    if (averange >= 70.0)
                        return "B";
                    else
                        return "A";
                }
            }
        }
    }
}
