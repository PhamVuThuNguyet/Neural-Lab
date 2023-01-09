using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralLab.Models
{
    sealed public class NeuralDataModel: LinkedList<NeuralDataModel>
    {
        public readonly int Id;
        public long VisualId;

        public double X; // Value used as a param of activation function;   
    }
}
