import React, { Component } from "react";
import publicService from "../services/publicService";

class About extends Component {
  state = { socialMediaLinks: [] };
  async componentDidMount() {
    const {
      data: socialMediaLinks
    } = await publicService.getSocialMediaLinks();
    this.setState({ socialMediaLinks });
  }
  render() {
    return (
      <div className="container">
        <div className="row">
          <div className="col">
            <h5>Hi!</h5>
            <p>
              You can call me 'Jayjay'. I'm a software engineer based in Manila.{" "}
            </p>
            <p>Here are some links to get to know me better:</p>
            {this.state.socialMediaLinks.map(sml => (
              <div className="about-links" key={sml.id}>
                <a
                  className="about-links__url"
                  href={sml.url}
                  target="_blank"
                  rel="noopener noreferrer"
                >
                  <i className={sml.fontAwesomeClass}></i>
                  <span className="about-links__username">{sml.username}</span>
                </a>
              </div>
            ))}
          </div>
        </div>
      </div>
    );
  }
}

export default About;
