using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceAndAbstractClasses
{
    /// <summary>
    /// Constructs and instance of Employee.
    /// </summary>
    public class Employee
    {
        private string _employeeID;
        private string _name;

        /// <summary>
        /// Gets the Employee's ID.
        /// </summary>
        public string EmployeeID
        {
            get
            {
                return _employeeID;
            }
        }

        /// <summary>
        /// Gets the Employee's name.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
        }

        /// <summary>
        /// Returns the result of the Employee being terminated.
        /// </summary>
        /// <returns>The result of the Employee being terminated.</returns>
        public string Terminated()
        {
            return "Employee is terminated.";
        }
    }
}
