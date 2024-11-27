var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.aspiretest_ApiService>("apiservice");

builder.AddProject<Projects.aspiretest_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
