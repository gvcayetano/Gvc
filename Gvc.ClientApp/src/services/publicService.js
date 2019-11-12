import http from "./httpService";

export function getSocialMediaLinks() {
  return http.get("/api/about");
}

export default {
  getSocialMediaLinks
};
