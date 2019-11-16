import React from "react";
import Moment from "react-moment";

const Footer = () => {
  return (
    <footer className="footer mt-auto py-3">
      <div className="container text-center">
        <small className="text-muted">
          <Moment format="YYYY">{new Date()}</Moment>
          &nbsp;
          <i className="fad fa-copyright"></i>
        </small>
      </div>
    </footer>
  );
};

export default Footer;
