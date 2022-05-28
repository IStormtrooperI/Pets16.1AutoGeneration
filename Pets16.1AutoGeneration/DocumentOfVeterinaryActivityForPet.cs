using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pets16._1AutoGeneration
{
    public class DocumentOfVeterinaryActivityForPet
    {
        private DateTime date;
        private string description;
        private string filePath;
        private long id_standardVeterinaryActivity;
        private long pet;
        private long veterinarytActivity;
        private bool wasPassed;

        public DocumentOfVeterinaryActivityForPet(long id_veterinaryActivity, long id_pet, long id_standardVeterinaryActivity, bool wasPassed, string description, DateTime date, string filePath)
        {
            throw new System.NotImplementedException();
        }

        public string FilePath
        {
            get => default;
            set
            {
            }
        }

        public Pet Pet
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