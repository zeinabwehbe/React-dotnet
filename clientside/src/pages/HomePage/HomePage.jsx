import React from "react";
import "./HomePage.css"; // Optional: Use this file for external styles if needed.

const HomePage = () => {
  return (
    <div>
      hello
      <header className="header">
        <h1>Welcome to Our Website</h1>
      </header>
      <nav className="nav">
        nav
      </nav>
      <section className="hero">
        <h1>Your Gateway to Success</h1>
        <p>We offer the best solutions to help your business grow.</p>
      </section>
      <div className="container">
        <h2>Our Features</h2>
        <div className="cards">
          <div className="card">
            <h3>Feature 1</h3>
            <p>Learn more about how we can help you achieve your goals.</p>
          </div>
          <div className="card">
            <h3>Feature 2</h3>
            <p>Explore our innovative services tailored to your needs.</p>
          </div>
          <div className="card">
            <h3>Feature 3</h3>
            <p>Discover tools and resources to enhance productivity.</p>
          </div>
        </div>
      </div>
      <footer className="footer">
        <p>&copy; 2024 Your Company. All rights reserved.</p>
      </footer>
    </div>
  );
};

export default HomePage;
