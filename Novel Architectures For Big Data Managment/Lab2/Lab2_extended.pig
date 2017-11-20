        -- 1. Show all users which have more than 100 reviews

A = LOAD '/home/mert/ml-20m/ratings.csv' USING PigStorage(',') AS (userId:int, movieId:int, rating:float, timestamp:long);
B = GROUP A BY userId;
C = FOREACH B GENERATE $0, COUNT(A) AS count;
D = FILTER C BY count > 100;
DUMP D;
-- DESCRIBE D;
-- EXPLAIN D;

	-- 1. Show all users which have more than 100 reviews


        -- 2. Show the total number of reviews for each movie

movieGroup = GROUP A BY movieId;
countMovie = FOREACH movieGroup GENERATE $0, COUNT(A) as count;
DUMP countMovie;
-- DESCRIBE countMovie;
-- EXPLAIN countMovie;

	-- 2. Show the total number of reviews for each movie

	-- 3. The average rating for ’Documentary’ movies

movies = LOAD '/home/mert/ml-20m/movies.csv' USING PigStorage(',') AS (movieId:int, movieName:chararray, movieType:chararray);

documentaryMovies = FILTER movies BY movieType MATCHES '.*Documentary.*'; 

documentaryMoviesId = FOREACH documentaryMovies GENERATE movieId;

filteredMoviesWithRating = JOIN documentaryMoviesId BY movieId FULL, A BY movieId;

groupped = GROUP filteredMoviesWithRating by documentaryMoviesId::movieId;

avgMovieRating = FOREACH groupped GENERATE (group) AS movieId, AVG(filteredMoviesWithRating.A::rating) AS avgRating;

-- DESCRIBE avgMovieRating;
DUMP avgMovieRating;
-- EXPLAIN avgMovieRating;

	-- 3. The average rating for ’Documentary’ movies

        -- 4. For each ’Action’ movie, the total number of tags that have been added

tags = LOAD '/home/mert/ml-20m/tags.csv' USING PigStorage(',') AS (userId:int, movieId:int, movieName:chararray, tag:chararray, timestamp:long);

actionMovies = FILTER movies BY movieType MATCHES '.*Action.*';

actionMoviesWithId = FOREACH actionMovies GENERATE movieId;

actionWtags = JOIN actionMoviesWithId BY movieId RIGHT, tags BY movieId;

groupped = GROUP actionWtags BY $0;

actionWcount = FOREACH groupped GENERATE group AS movieId, COUNT(actionWtags) as tagCount;

-- DESCRIBE actionWcount;

DUMP actionWcount;

-- EXPLAIN actionWcount;
	
	-- 4. For each ’Action’ movie, the total number of tags that have been added
