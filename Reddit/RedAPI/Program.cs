using Microsoft.EntityFrameworkCore;
using RedAPI.Models;
using RedAPI.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();


var AllowSomeStuff = "_AllowSomeStuff";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowSomeStuff, builder => {
        builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});


builder.Services.AddDbContext<PostContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ContextSQLite")));

builder.Services.AddScoped<DataService>();


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dataService = scope.ServiceProvider.GetRequiredService<DataService>();
    dataService.SeedData(); // Fylder data på, hvis databasen er tom. Ellers ikke.
}

app.Use(async (context, next) =>
{
    context.Response.ContentType = "application/json; charset=utf-8";
    await next(context);
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();



//GET

app.MapGet("/api/posts", (DataService service) => service.GetPosts());

app.MapGet("/api/posts/{id:long}", (DataService service, long id) =>
{
    var post = service.GetPost(id);
    if (post == null)
        return Results.NotFound();
    return Results.Ok(post);
});
    

//PUT

app.MapPut("/api/posts/{id:long}/upvote", (DataService service, long id) =>
{
    var post = service.UpvotePost(id);
    if (post == null)
        return Results.NotFound();
    return Results.Ok(post);

});


app.MapPut("/api/posts/{id:long}/downvote", (DataService service, long id) =>
{
    var post = service.DownvotePost(id);
    if (post == null)
        return Results.NotFound();
    return Results.Ok(post);
});


app.MapPut("/api/posts/{postId:long}/comments/{commentId:long}/upvote",
    (DataService service, long postId, long commentId) =>
    {
        var comment = service.UpvoteComment(postId, commentId);
        if (comment == null)
            return Results.NotFound();
        return Results.Ok(comment);
    });


app.MapPut("/api/posts/{postId:long}/comments/{commentId:long}/downvote",
    (DataService service, long postId, long commentId) =>
    {
        var comment = service.DownvoteComment(postId, commentId);
        if (comment == null)
            return Results.NotFound();
        return Results.Ok(comment);
    });
                
//POST:

app.MapPost("/api/posts", (DataService service, RecordPost post) =>
{
    var newPost = service.PostPost(post);
    if (newPost == null)
        return Results.Conflict();
    return Results.Ok(newPost);
});

app.MapPost("/api/posts/{postId:long}/comments", (DataService service, long postId, RecordComment comment) =>
{
    var newComment = service.PostComment(postId, comment);
    if(newComment.CommentId == -1)
        return Results.NotFound();
    if(newComment.CommentId == -2)
        return Results.Conflict();
    
    return Results.Ok(newComment);
});
    
app.Run();

public record RecordPost(string Title, string Content, string Author);
public record RecordComment(string Author, string Content);