using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldReturnTest
{
    class ProductCollection : IEnumerable<Product>
    {
        private List<Product> products;

        public ProductCollection()
        {
            this.products = new List<Product>();
        }
        public void Add(Product product)
        {
            this.products.Add(product);
        }
        public IEnumerator<Product> GetEnumerator()
        {
            return new ProductCollectionEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private class ProductCollectionEnumerator : IEnumerator<Product>
        {
            ProductCollection productCollection;
            int currentIndex = -1;

            public ProductCollectionEnumerator(ProductCollection products)
            {
                this.productCollection = products;
            }
            public Product Current
            {
                get
                {
                    return this.productCollection.products[currentIndex];
                }
            }

            public bool MoveNext()
            {
                return ++currentIndex < this.productCollection.products.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }


            object IEnumerator.Current
            {
                get
                {
                    return this.productCollection.products[currentIndex];
                }
            }
            public void Dispose()
            {

            }

        }
    }

}
