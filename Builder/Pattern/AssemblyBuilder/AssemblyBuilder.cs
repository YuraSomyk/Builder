using Builder.Product;

namespace Builder.Pattern.AssemblyBuilder {

    class AssemblyBuilder: Builder {

        CocaCola CocaCola = new CocaCola();

        public override CocaCola BuildCocaCola(Bottle bottle, Watter watter, Cover cover) {
            CocaCola.Add(bottle);
            CocaCola.Add(watter);
            CocaCola.Add(cover);

            return CocaCola;
        }
    }
}