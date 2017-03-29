using System.Collections.Generic;

namespace GeneticAlgorithm.Api
{
    public class Chassis
    {
        public readonly List<float> Vecteurs = new List<float>();
        public float Densite;

        public override string ToString()
        {
            return "Chassis{" +
                   "vecteurs=" + Vecteurs +
                   ", Densite=" + Densite +
                   '}';
        }
    }
}