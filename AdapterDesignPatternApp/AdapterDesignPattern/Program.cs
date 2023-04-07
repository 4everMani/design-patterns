using AdapterDesignPattern._3rdPartyFilters;
using AdapterDesignPattern.adapetrs;
using AdapterDesignPattern.models;

/// Using local filter
var image = new Image();
image.UseFilter(new VividFilter());

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
/// Using 3rdParty Filter
var image2 = new Image();
//image2.UseFilter(new SnowWhite()); this will throw error coz SnowWhite is implemented IFilter interface
var snowWhiteFilter = new SnowWhite();
var adapter = new FilterAdapter(snowWhiteFilter);
image2.UseFilter(adapter);
