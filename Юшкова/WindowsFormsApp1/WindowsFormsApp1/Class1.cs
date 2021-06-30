using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Class1
    {
        /// <summary>
        /// Информация о вершине
        /// </summary>
        public class GraphVertexInfo
        {
            internal IEnumerable<object> Vertices;

            /// <summary>
            /// Вершина
            /// </summary>
            public GraphVertex Vertex { get; set; }

            /// <summary>
            /// Не посещенная вершина
            /// </summary>
            public bool IsUnvisited { get; set; }

            /// <summary>
            /// Сумма ребер
            /// </summary>
            public int EdgesWeightSum { get; set; }

            /// <summary>
            /// Предыдущая вершина
            /// </summary>
            public GraphVertex PreviousVertex { get; set; }

            /// <summary>
            /// Конструктор
            /// </summary>
            /// <param name="vertex">Вершина</param>
            public GraphVertexInfo(GraphVertex vertex)
            {
                Vertex = vertex;
                IsUnvisited = true;
                EdgesWeightSum = int.MinValue;
                PreviousVertex = null;
            }

            internal string FindVertex(string startName)
            {
                throw new NotImplementedException();
            }
        }
    }
}
