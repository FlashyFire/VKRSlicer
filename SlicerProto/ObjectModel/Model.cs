using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using SlicerProto.Utils;

namespace SlicerProto.ObjectModel
{
    public class Model
    {
        private const int FacetCountThreshold = 10000;
        private ObjectDimensions dimensions = null;

        public string Name { get; set; }
        public List<Facet> Facets { get; } = new List<Facet>();
        public ObjectDimensions Dimensions {
            get {
                if (dimensions == null)
                    dimensions = CalcDimensions();
                return dimensions;
            }
        }
        public bool IsEmpty => Facets.Count == 0;

        public void Clear()
        {
            Name = string.Empty;
            Facets.Clear();
            dimensions = null;
        }

        private ObjectDimensions CalcDimensions()
        {
            ObjectDimensions result = new ObjectDimensions();
            if (Facets.Count > 0)
            {
                result.Initialize(Facets[0]);
                if (Facets.Count < FacetCountThreshold)
                {
                    for (int i = 1; i < Facets.Count; i++)
                        result.Aggregate(Facets[i]);
                }
                else
                {
                    result = Facets.AsParallel().Aggregate(result, 
                        (acc, item) => { acc.Aggregate(item); return acc; });
                }
            }
            return result;
        }

        public void Transform(Matrix3 matrix)
        {
            if (Facets.Count < FacetCountThreshold)
            {
                Facets.ForEach(x => x.Transform(matrix));
            }
            else
            {
                Facets.AsParallel().ForAll(x => x.Transform(matrix));
            }
            dimensions = null;
        }

        public Model Clone()
        {
            Model result = new Model();
            result.Name = Name;
            foreach(Facet facet in Facets)
            {
                result.Facets.Add(facet.Clone());
            }
            return result;
        }
    }
}
