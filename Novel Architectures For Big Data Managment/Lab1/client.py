def getBookInformation():
    string = " Book with "
    for i in book.keys():
        string += i+" = " +book.get(i)+", "
    return string + " be quick to borrow this book, you have "+str(r.ttl('books:'+ unique)) +" seconds left"
if __name__ == '__main__':
    import redis

    r = redis.StrictRedis(host='localhost', port=6379, db=0)
    var = 'N'

    while (var != 'Y'):

        # get isbn and edition number
        while True:
            try:
                isbn = int(input("Please enter ISBN of the book "))
                isbn = str(isbn)
                edition = int(input("Please enter edition number of the book "))
                edition = str(edition)
                break
            except:
                print("That's not a valid option! ")

        unique = isbn + edition
        # check if book is in the database.
        if (r.hget("books:"+unique,"isbn") == None):

            # get author from admin:
            while True:
                try:
                    author = str(raw_input("Please enter author of the book "))
                    title = str(raw_input("Please enter title of the book "))
                    break
                except:
                    print("That's not a valid option!")
            # get other attributes if needed

            # add book dictionnary
            book = {}
            book ["isbn"] = isbn
            book ["author"] = author
            book ["edition"] = edition
            book ["title"] = title
            # add book
            r.hmset('books:'+ unique,book)
            # they expire in 115 seconds.
            r.expire('books:'+unique,115)
            # publish in the channels
            for field in book:
                    r.publish(book[field],getBookInformation())

                    # if it has multiple item publish all of them
                    if " " in book[field]:
                       for word in str(book[field]).split():
                           r.publish(word,getBookInformation())




        else:
            print("Book with "+isbn+" isbn and with edition number "+edition+" is already in the database.")

        var = raw_input("If you want to quit of this application please enter 'Y' ")


