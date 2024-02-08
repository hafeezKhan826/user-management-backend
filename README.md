Swagger documentation can be found at "http://localhost:5162/swagger".

List the APIs along with their corresponding curl commands and payloads:
1. [GET] /api/profile - gets all profiles - 
             
        curl -X 'GET' \
        'http://localhost:5162/api/profile' \
        -H 'accept: text/plain'

2. [POST] /api/profile - creates a profile.
      
        curl -X 'POST' \
        'http://localhost:5162/api/profile' \
        -H 'accept: */*' \
        -H 'Content-Type: application/json' \
        -d '{
        "name": "Hafeez Demo",
        "email": "hafeez@demo.com",
        "profilePicture": "https://randomuser.me/api/portraits/lego/5.jpg",
        "bio": "Hafeez Demo",
        "password": "123456"
      }'

3. [GET] /api/profile/{id} - gets one/null profile.

         curl -X 'GET' \
        'http://localhost:5162/api/profile/65c3100c15591df72ec22679' \
        -H 'accept: text/plain'
    
4. [GET] /api/profile/deactivatedUsers - gets all deactivated profiles.

        curl -X 'GET' \
        'http://localhost:5162/api/profile/deactivatedUsers' \
        -H 'accept: text/plain'


5. [PUT] /api/profile/{id} - replaces entire document matching **id** param.

       curl -X 'PUT' \
          'http://localhost:5162/api/profile/65c3100c15591df72ec22671' \
          -H 'accept: */*' \
          -H 'Content-Type: application/json' \
          -d '{
            "id":"65c3100c15591df72ec22671",
            "name": "Hafeez Khan 123",
            "email": "hafeez@gmail.com",
            "profilePicture": "https://randomuser.me/api/portraits/lego/1.jpg",
            "bio": "Hello",
            "isAvailable": true,
            "password": "123456"
        }'


6. [DELETE] /api/profile/{id} - flag a using as inactive.

          curl -X 'DELETE' \
        'http://localhost:5162/api/profile/65c3100c15591df72ec22671' \
        -H 'accept: */*'

7. [PATCH] /api/profile/reactivate/{id} - reactivates a flagged user.

        curl -X 'PATCH' \
        'http://localhost:5162/api/profile/reactivate/65c31906ff4b5f7e9280eeee' \
        -H 'accept: */*'

