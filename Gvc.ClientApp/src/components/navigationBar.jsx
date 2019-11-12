import React from "react";

import { Navbar, Nav } from "react-bootstrap";
import { LinkContainer } from "react-router-bootstrap";

const NavigationBar = () => {
  return (
    <header className="border-bottom box-shadow mb-3">
      <div className="container">
        <Navbar bg="transparent" expand="lg">
          <LinkContainer to="/">
            <Navbar.Brand>
              <i className="fad fa-code"></i>GVC
            </Navbar.Brand>
          </LinkContainer>
          <Navbar.Toggle aria-controls="navigation-bar" />
          <Navbar.Collapse id="navigation-bar">
            <Nav className="ml-auto">
              <LinkContainer exact to="/">
                <Nav.Link>Home</Nav.Link>
              </LinkContainer>
              <LinkContainer to="/about">
                <Nav.Link>About</Nav.Link>
              </LinkContainer>
            </Nav>
          </Navbar.Collapse>
        </Navbar>
      </div>
    </header>
  );
};

export default NavigationBar;
