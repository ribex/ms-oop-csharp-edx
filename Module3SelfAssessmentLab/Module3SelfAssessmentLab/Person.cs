using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Module3SelfAssessmentLab
{
    public abstract class Person : IDisposable
    {
        private string _name;
        private int _age;
        private string _cityOfResidence;
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (handle != null)
                    {
                        handle.Dispose();
                    }
                }

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string CityOfResidence
        {
            get { return _cityOfResidence; }
            set { _cityOfResidence = value; }
        }

        public Person(string name, int age, string cityOfResidence)
        {
            this.Name = name;
            this.Age = age;
            this.CityOfResidence = cityOfResidence;
        }

        public void WriteData(string path)
        {
            if (this.disposed)
            {
                throw new ObjectDisposedException("Person");
            }

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            TextWriter tw = new StreamWriter(path, true);

            tw.WriteLine($"{this.Name} is from {this.CityOfResidence} and is {this.Age} years old.");

            tw.Close();
        }

    }
}
