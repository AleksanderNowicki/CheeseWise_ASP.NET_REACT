# CheeseWise_ASP.NET_REACT
Created using ASP.NET Core, React and postgreSQL.

App deployed at: https://cheesewise.azurewebsites.net/

Application allows to reserch companies by category.

As a register user
* You can create your company profile with services that it offers.
* Rate other companies (in progress)

## Technologies
#### BACK-END
* Entity Framework Core (3.0.1)
* JWT (5.3.1)
* Microsoft.AspNetCore.Authentication.JwtBearer (3.0.0)
* CryptoHelper (3.0.2)
* Npgsql.EntityFrameworkCore.PostgreSQL (3.1.0)
* Swashbuckle.AspNetCore (5.0.0-rc5)
#### FRONT-END
* babel-eslint (10.0.1)
* bootstrap (4.1.3)
* history (4.10.1)
* jquery (3.4.1)
* jwt-decode (2.2.0)
* merge (1.2.1)
* oidc-client (1.9.0)
* react (16.0.0)
* react-dom (16.0.0)
* react-redux (7.1.3)
* react-router-bootstrap (0.24.4)
* react-router-dom (4.2.2)
* react-scripts (3.0.1)
* reactstrap (6.3.0)
* redux (4.0.4)
* redux-devtools-extension (2.13.8)
* rimraf (2.6.2)

# Setup
To run this project:
  * Clone repo
  * Open CheeseWiseSolution using Visual Studio
  * Install frontend modules
    ```
    $ cd ../ClientApp
    $ npm install
    ```
  * Run application using ISS Express (server runner built-in VisualStudio)
