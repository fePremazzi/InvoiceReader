using Azure.Storage.Blobs;
using InvoiceReaderAPI.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddSingleton<IBlobStorageService>();
//builder.Services.AddSingleton<IDatabaseService>();
//builder.Services.AddSingleton<IFormRecognizerService>();
//builder.Services.AddSingleton<BlobContainerClient>();
//builder.Services.AddSingleton<BlobServiceClient>();
builder.Services.AddSingleton<BlobStorageService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
