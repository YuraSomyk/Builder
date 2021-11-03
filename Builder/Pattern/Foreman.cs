using Builder.Product;
using System;

namespace Builder.Pattern {

    class Foreman {

        Builder.Builder _builder;
        AssemblyBuilder.AssemblyBuilder _assemblyBuilder;

        public Foreman(Builder.Builder builder, AssemblyBuilder.AssemblyBuilder assemblyBuilder) {
            this._builder = builder;
            this._assemblyBuilder = assemblyBuilder;
        }

        public CocaCola Construct() {
            var bottle = _builder.BuildBottle();
            var watter = _builder.BuildWatter();
            var cover = _builder.BuildCover();
            return _assemblyBuilder.BuildCocaCola(bottle, watter, cover);
        }
    }
}