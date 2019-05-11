using System;
using System.Data;
using System.Diagnostics;
namespace SampleConApp
{
    /*
     * methods inside an interface is always public and must not have any access specifier
     * U cannot have fields in an interface, however, U could have properties. 
     * UR class could implement multiple interfaces at the same level.
     * The class that implements the interface must implement all the methods of the interface, else U should atleast redefine the methods as abstract and mark the class as abstract..
     * UR class must implement the methods of the interface with public access only.
     */
    interface IDataComponent
    {
        void AddNewEmployee(int id, string name, string address);
        void UpdateEmployee(int id, string name, string address);
        void DeleteEmployee(int id);
        DataTable GetAllEmployees();
    }

    class DataComponent : IDataComponent
    {
        private DataTable table;
        public DataComponent()
        {
            table = new DataTable("Employees");
            table.Columns.Add("EmpID", typeof(int));
            table.Columns.Add("EmpName", typeof(string));
            table.Columns.Add("EmpAddress", typeof(string));
            table.PrimaryKey = new DataColumn[] { table.Columns[0] };
            table.AcceptChanges();//Update...
        }

        public void AddNewEmployee(int id, string name, string address)
        {
            //How to add data into a DataTable?
            //Create a Row initialized to the schema of the row
            DataRow row = table.NewRow();
            //set values to the row...
            row[0] = id;
            row[1] = name;
            row[2] = address;
            //add the row to the table
            table.Rows.Add(row);
            //update
            table.AcceptChanges();
            Trace.WriteLine("The no of Rows: " + table.Rows.Count);
        }

        public void DeleteEmployee(int id)
        {
            foreach(DataRow row in table.Rows)
            {
                if(row[0].ToString() == id.ToString())
                {
                    row.Delete();
                    table.AcceptChanges();
                    return;
                }
            }
            throw new Exception("No Employee found to delete");
        }

        public DataTable GetAllEmployees()
        {
            return table;
        }

        public void UpdateEmployee(int id, string name, string address)
        {
            foreach (DataRow row in table.Rows)
            {
                if (row[0].ToString() == id.ToString())
                {
                    row[1] = name;
                    row[2] = address;
                    table.AcceptChanges();
                    return;
                }
            }
            throw new Exception("No Employee found to delete");
        }
    }
    class InterfaceDemo
    {
        static void Main(string[] args)
        {
            IDataComponent component = new DataComponent();
            component.AddNewEmployee(123, "Phaniraj", "Bangalore");
            
            component.AddNewEmployee(124, "Vinod", "Bangalore");
            component.AddNewEmployee(125, "Ananth Kumar", "Bangalore");
            component.AddNewEmployee(126, "Devaraj", "Bangalore");
            component.AddNewEmployee(127, "Suman", "Bangalore");
            //component.AddNewEmployee(123, "Phaniraj", "Bangalore");

            DataTable table = component.GetAllEmployees();
            foreach(DataRow row in table.Rows)
                Console.WriteLine($"{row[0]}\t{row[1]}");

        }
    }
}