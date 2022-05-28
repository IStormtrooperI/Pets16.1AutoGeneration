using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pets16._1AutoGeneration
{
    public class StandardVeterinaryActivity
    {
        private DateTime date;
        private string description;
        private string filePath;
        private long id_pet;
        private long veterinaryActivity;
        private bool wasPassed;

        public StandardVeterinaryActivity(long id_veterinaryActivity, long id_pet, long id_standardVeterinaryActivity, bool wasPassed, string description, DateTime date, string filePath)
        {
            throw new System.NotImplementedException();
        }

        public long Id
        {
            get => default;
            set
            {
            }
        }

        public string Name
        {
            get => default;
            set
            {
            }
        }

        public VeterinaryActivity VeterinaryActivity
        {
            get => default;
            set
            {
            }
        }
    }
}