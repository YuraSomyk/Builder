using Builder.Product;

namespace Builder.Pattern.AssemblyBuilder {

    abstract class Builder {

        public abstract CocaCola BuildCocaCola(Bottle bottle, Watter watter, Cover cover);
    }
}