using OOP.Constructions.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Constructions
{
    internal class Construction
    {
        public Construction()
        {
            Height = 23;
            Width = 45;
            Entrances = 4;
            HumanCapacity = 12;
            BuildMaterial = "Material";
            Roofing = "Asbestos";
        }
        public Construction(CreateConstructionDto construction)
        {
            Height = construction.Height;
            Width = construction.Width;
            Entrances = construction.Entrances;
            HumanCapacity = 2;
            BuildMaterial = construction.BuildMaterial;
        }
        public Construction(float height, float width, int entrances, int humancapacity, string buildmaterial,string roofing)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humancapacity;
            BuildMaterial = buildmaterial;
            Roofing = roofing;

        }
        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public string Roofing {  get; set; }
        private string _buildMaterial { get; set; }
        public string BuildMaterial
            
        {
            get
            {
                return _buildMaterial;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value cannot be null");
                }
                _buildMaterial = value;
            }

        }
    }
}
    
//1.Height typu zmiennoprzecinkowego
//2. Width typu zmiennoprzecinkowego
//3. Entrances typu liczba całkowita
//4. HumanCapacity typu liczba całkowita
//5. BuildMaterial typu tekstowego