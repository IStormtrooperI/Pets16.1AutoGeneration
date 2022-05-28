using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pets16._1AutoGeneration
{
    public class Pet
    {
        private long category;
        private System.Collections.Generic.Dictionary<dynamic, dynamic> documentOfVeterinaryActivities;
        private long gender;
        private System.Collections.Generic.Dictionary<dynamic, dynamic> photos;
        private long size;
        private System.Collections.Generic.Dictionary<dynamic, dynamic> vaccinations;
        private System.Collections.Generic.Dictionary<dynamic, dynamic> veterinaryActivities;
        private long wool;

        public Pet(long id_pet)
        {
            throw new System.NotImplementedException();
        }

        public Pet(long id_pet, long id_gender, long id_category, string id_size, long id_wool, string name, string breed, System.DateTime dateRegistry, System.DateTime birthday, string passportNumber, string ownerName)
        {
            throw new System.NotImplementedException();
        }

        public System.DateTime Birthday
        {
            get => default;
            set
            {
            }
        }

        public string Breed
        {
            get => default;
            set
            {
            }
        }

        public Category Category
        {
            get => default;
            set
            {
            }
        }

        public System.DateTime DateRegistry
        {
            get => default;
            set
            {
            }
        }

        public System.Collections.Generic.Dictionary<long, long> DocumentsOfVeterinaryActivities
        {
            get => default;
            set
            {
            }
        }

        public Gender Gender
        {
            get => default;
            set
            {
            }
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

        public string OwnerName
        {
            get => default;
            set
            {
            }
        }

        public string PassportNumber
        {
            get => default;
            set
            {
            }
        }

        public System.Collections.Generic.Dictionary<long, long> Photos
        {
            get => default;
            set
            {
            }
        }

        public System.Drawing.Size Size
        {
            get => default;
            set
            {
            }
        }

        public System.Collections.Generic.Dictionary<long, long> Vaccinations
        {
            get => default;
            set
            {
            }
        }

        public Wool Wool
        {
            get => default;
            set
            {
            }
        }
    }
}