


CarroDiretor diretor = new CarroDiretor (); 

CarroPopularBuilder builder = new CarroPopularBuilder();
diretor.CriarCarroPopular(builder);
CarroPopular carroPopular  = builder.GetResult();

CarroLuxoBuilder builderLuxo = new CarroLuxoBuilder ();
diretor.CriarCarroLuxo(builderLuxo);
CarroLuxo carroLuxo = builderLuxo.GetResult();