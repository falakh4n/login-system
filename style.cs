* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: "Poppins", sans-serif;
}

body {
    background-color: #333;
    background: linear-gradient(to right, #333, #555);
}

.container {
    background: #2c2c2c; /* Dark Charcoal Grey */
    width: 450px;
    padding: 1.5rem;
    margin: 50px auto;
    border-radius: 10px;
    box-shadow: 0 20px 35px rgba(0, 0, 0, 0.9);
}

form {
    margin: 0 2rem;
}

.form-title {
    font-size: 1.5rem;
    font-weight: bold;
    text-align: center;
    padding: 1.3rem;
    margin-bottom: 0.4rem;
    color: #00bcd4; /* Teal */
}

input {
    color: inherit;
    width: 100%;
    background-color: transparent;
    border: none;
    border-bottom: 1px solid #555; /* Medium Grey */
    padding-left: 1.5rem;
    font-size: 15px;
}

.input-group {
    padding: 1% 0;
    position: relative;
}

.input-group i {
    position: absolute;
    color: #00bcd4; /* Teal */
}

input:focus {
    background-color: transparent;
    outline: transparent;
    border-bottom: 2px solid #00bcd4; /* Teal */
}

input::placeholder {
    color: transparent;
}

label {
    color: #757575; /* Grey */
    position: relative;
    left: 1.2em;
    top: -1.3em;
    cursor: auto;
    transition: 0.3s ease all;
}

input:focus ~ label, input:not(:placeholder-shown) ~ label {
    top: -3em;
    color: #00bcd4; /* Teal */
    font-size: 15px;
}

.recover {
    text-align: right;
    font-size: 1rem;
    margin-bottom: 1rem;
}

.recover a {
    text-decoration: none;
    color: #00bcd4; /* Teal */
}

.recover a:hover {
    color: #0097a7; /* Darker Teal */
    text-decoration: underline;
}

.btn {
    font-size: 1.1rem;
    padding: 8px 0;
    border-radius: 5px;
    outline: none;
    border: none;
    width: 100%;
    background: #00bcd4; /* Teal */
    color: white;
    cursor: pointer;
    transition: 0.9s;
}

.btn:hover {
    background: #0097a7; /* Darker Teal */
}

.or {
    font-size: 1.1rem;
    margin-top: 0.5rem;
    text-align: center;
    color: #757575; /* Grey */
}

.icons {
    text-align: center;
}

.icons i {
    color: #00bcd4; /* Teal */
    padding: 0.8rem 1.5rem;
    border-radius: 10px;
    font-size: 1.5rem;
    cursor: pointer;
    border: 2px solid #2c2c2c; /* Dark Charcoal Grey */
    margin: 0 15px;
    transition: 1s;
}

.icons i:hover {
    background: #0097a7; /* Darker Teal */
    font-size: 1.6rem;
    border: 2px solid #00bcd4; /* Teal */
}

.links {
    display: flex;
    justify-content: space-around;
    padding: 0 4rem;
    margin-top: 0.9rem;
    font-weight: bold;
}

button {
    color: #00bcd4; /* Teal */
    border: none;
    background-color: transparent;
    font-size: 1rem;
    font-weight: bold;
}

button:hover {
    text-decoration: underline;
    color: #0097a7; /* Darker Teal */
}
