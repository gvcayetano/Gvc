import React from "react";

import { Navbar, Nav } from "react-bootstrap";
import { LinkContainer } from "react-router-bootstrap";

const NavigationBar = () => {
  return (
    <div className="container">
      <Navbar bg="transparent" expand="lg">
        <LinkContainer to="/">
          <Navbar.Brand>GVC</Navbar.Brand>
        </LinkContainer>
        <Navbar.Toggle aria-controls="navigation-bar" />
        <Navbar.Collapse id="navigation-bar">
          <Nav className="ml-auto">
            <LinkContainer to="/">
              <Nav.Link>Home</Nav.Link>
            </LinkContainer>
            <LinkContainer to="/about">
              <Nav.Link>About</Nav.Link>
            </LinkContainer>
          </Nav>
        </Navbar.Collapse>
      </Navbar>
    </div>
  );
};

export default NavigationBar;
