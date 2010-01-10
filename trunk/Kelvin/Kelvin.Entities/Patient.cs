using System;
using System.Collections.Generic;
using System.Text;

namespace Kelvin.Entities
{
    public class Patient
    {
        private int _patientId;

        public int PatientId
        {
            get { return _patientId; }
            set { _patientId = value; }
        }

        private string _patientFullName;

        public string PatientFullName
        {
            get { return _patientFullName; }
            set { _patientFullName = value; }
        }

        private string _patientFirstName;

        public string PatientFirstName
        {
            get { return _patientFirstName; }
            set { _patientFirstName = value; }
        }

        private string _patientLastName;

        public string PatientLastName
        {
            get { return _patientLastName; }
            set { _patientLastName = value; }
        }

        public DateTime _dob;

        public DateTime DOB
        {
            get { return _dob; }
            set { _dob = value; }
        }

        public string _ssn;

        public string SSN
        {
            get { return _ssn; }
            set { _ssn = value; }
        }

        public string _contactNo;

        public string ContactNo
        {
            get { return _contactNo; }
            set { _contactNo = value; }
        }

        public string _emailId;

        public string EmailId
        {
            get { return _emailId; }
            set { _emailId = value; }
        }

        public string _facility;

        public string Facility
        {
            get { return _facility; }
            set { _facility = value; }
        }

        public string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string _bloodGroup;

        public string BloodGroup
        {
            get { return _bloodGroup; }
            set { _bloodGroup = value; }
        }

        public string _medicareNumber;

        public string MedicareNumber
        {
            get { return _medicareNumber; }
            set { _medicareNumber = value; }
        }

        public string _consultingDoctor;

        public string ConsultingDoctor
        {
            get { return _consultingDoctor; }
            set { _consultingDoctor = value; }
        }

        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
    }
}
