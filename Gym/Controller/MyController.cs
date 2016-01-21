using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM
{
    class MyController
    {
       


        // insert Trainee details into table Trainees as a new record
        internal static bool InsertTrainee(string TraineeID, string firstName, string lastName, string age, string city)
        {
            try
            {
                
                string query = "Insert into Trainees values('" + TraineeID + "' , '" + firstName + "' , '" + lastName + "' , '" + age + "' , '" + city + "')";
                MyModel.ExecuteNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }

        }


        public static string getQuantity(string itemNumber)
        {

            string query = "select quantity from ItemsForSale where ItemID='"+ itemNumber+"'";

            try
            {
                DataTable dt = MyModel.ExecuteDataTable(query);
                
                            string quant = dt.Rows[0]["quantity"].ToString();
                            return quant;
            }
            catch
            {
                return null;
            }
          
        }

        internal static void purchaseItem(string itemNumber)
        {
            string query = "select quantity from ItemsForSale where ItemID='" + itemNumber + "'";
            DataTable dt = MyModel.ExecuteDataTable(query);
            int quant = Convert.ToInt16( dt.Rows[0]["quantity"]);
            quant--;
            int i = 0;

            i++;
            string query2 = "update ItemsForSale set quantity ='" + quant + "' where  ItemID='" + itemNumber + "'";
            MyModel.ExecuteNonQuery(query2);
        }

        internal static DataTable GetData(string itemNumber)
        {
            string query = "select * from ItemsForSale where ItemID='" + itemNumber + "'";

            try
            {
                DataTable dt = MyModel.ExecuteDataTable(query);

                string quant = dt.Rows[0]["quantity"].ToString();
                return dt;
            }
            catch
            {
                return null;
            }
        }

        internal static bool checkIfUserExists(string TraineeID)
        {
            bool ans = false;
            string query= "select TraineeID from Trainees";
            DataTable dt = MyModel.ExecuteDataTable(query);
            for (int i=0;i<dt.Rows.Count;i++)
            {
                string check = dt.Rows[i][0].ToString();
                if (check == TraineeID)
                    return true;
            }
            return ans;
            
        }
        internal static List<string> getClassesNamesList()
        {
            List<string> classNameList = new List<string>();
            string query = "select className from Classes ";
            DataTable dt = MyModel.ExecuteDataTable(query);

            foreach (DataRow datarow in dt.Rows)
            {
                string className = datarow["className"].ToString();
                classNameList.Add(className);
            }
            return classNameList;

        }

        internal static DataRow getClassDetailsRow(string className)
        {
            string query = "select * from Classes where ClassName='" + className + "'";
            DataTable dt = MyModel.ExecuteDataTable(query);
            DataRow datarow = dt.Rows[0];
            return datarow;
        }
    }
}
