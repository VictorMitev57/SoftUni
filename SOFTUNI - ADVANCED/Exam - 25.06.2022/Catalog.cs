using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;
        private string name;
        private int neededRenovators;
        private string project;

        public List<Renovator> Renovators { get => renovators; set => renovators = value; }
        public string Name { get => name; set => name = value; }
        public int NeededRenovators { get => neededRenovators; set => neededRenovators = value; }
        public string Project { get => project; set => project = value; }

        public Catalog( string name, int neededRenovators, string project)
        {
            Renovators = new List<Renovator>();
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
        }

        private int count;

        public int Count
        {
            get { return Renovators.Count; }
        }

        public string AddRenovator(Renovator renovator)
        {
            string text = "";
            int index = renovators.IndexOf(renovator);
            if (string.IsNullOrEmpty(renovators[index].Name) ||
                string.IsNullOrEmpty(renovators[index].Name))
            {
                text = "Invalid renovator's information.";
            }
            if (Count < NeededRenovators)
            {
                if (renovator.Rate > 350)
                {
                    text = "Invalid renovator's rate.";
                }
                else
                {
                    renovators.Add(renovator);
                    text = $"Successfully added {renovator.Name} to the catalog.";
                }
            }
            else
            {
                text = "Renovators are no more needed.";
            }
            return text;
        }
        public bool RemoveRenovator(string name)
        {
            bool isExist = false;
            foreach (var el in renovators)
            {
                if (el.Name == name)
                {
                    isExist =  true;
                    renovators.Remove(el);
                }
                else
                {
                    isExist = false;
                }
            }
            return isExist;
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            int count = 0;
            foreach (var el in renovators)
            {
                if (el.Type == type)
                {
                    renovators.Remove(el);
                    count++;
                }
            }
            return count;
        }

        public Renovator HireRenovator(string name) 
        {
            string text = "";
            foreach (var el in renovators)
            {
                if (el.Name == name)
                {
                     = true;
                }
                else
                {
                    text = "0";
                }
            }
            return text;
        }
        public List<Renovator> PayRenovators(int days)
        {
            List<Renovator> workedDays = new List<Renovator>();
            foreach (var el in renovators)
            {
                if (el.Days >= days)
                {
                    workedDays.Add(el);
                }
            }
            return workedDays;
        }
        public string Report()
        {
            StringBuilder notHired = new StringBuilder();
            notHired.AppendLine($"Renovators available for Project {project}:");
            foreach (var el in renovators)
            {
                notHired.AppendLine(el.ToString());
            }
            return notHired.ToString();
        }

    }
}
