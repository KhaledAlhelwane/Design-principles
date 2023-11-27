

//what stay the same is isolated from what change often
//logic that keep changing,candidt to be reuse

#region before using Enacpsulate what variant
//using EncapsulateWhatVariant.before;
//Pizaa pizaa = Pizaa.order("Cheese");
//Console.WriteLine(pizaa);
#endregion


#region After using Enacpsulate what variant
using EncapsulateWhatVariant.After;
Pizaa pizaa = Pizaa.order(PizaaContants.Vegpiza);
Console.WriteLine(pizaa);

#endregion