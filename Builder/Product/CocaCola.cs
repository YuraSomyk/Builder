using System.Collections;

namespace Builder.Product {

    class CocaCola {

        ArrayList parts = new ArrayList();

        public void Add(object part) {
            parts.Add(part);
        }
    }
}