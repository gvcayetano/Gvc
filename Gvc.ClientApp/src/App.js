import React from "react";
import { Route, Switch } from "react-router-dom";
import { ToastContainer } from "react-toastify";

import About from "./components/about";
import Home from "./components/home";
import NavigationBar from "./components/navigationBar";
import Footer from "./components/footer";

function App() {
  return (
    <React.Fragment>
      <ToastContainer position="bottom-right" />
      <NavigationBar />
      <main role="main" className="flex-shrink-0">
        <div className="container">
          <Switch>
            <Route path="/about" component={About} />
            <Route path="/" component={Home} />
          </Switch>
        </div>
      </main>
      <Footer></Footer>
    </React.Fragment>
  );
}

export default App;
