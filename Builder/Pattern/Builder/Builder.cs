using Builder.Product;

namespace Builder.Pattern.Builder {

    abstract class Builder {

        public abstract Bottle BuildBottle();

        public abstract Cover BuildCover();

        public abstract Watter BuildWatter();
    }
}