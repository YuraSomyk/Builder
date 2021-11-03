using Builder.Product;

namespace Builder.Pattern.Builder {

    class ConcreteBuilder : Builder {

        public override Bottle BuildBottle() {
            return new Bottle();
        }

        public override Cover BuildCover() {
            return new Cover();
        }

        public override Watter BuildWatter() {
            return new Watter();
        }
    }
}