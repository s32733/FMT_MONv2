using FMT_MONv2v2.Services;
using FMT_MONv2v2.Repositories;



var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<IReviewsService, ReviewsService>();
builder.Services.AddScoped<IReviewsRepository, ReviewsRepository>();

var app = builder.Build();
app.UseHttpsRedirection();
app.MapControllers();
app.Run();