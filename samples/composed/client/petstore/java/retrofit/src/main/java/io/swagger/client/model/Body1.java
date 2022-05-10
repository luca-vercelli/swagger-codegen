/*
 * Swagger Petstore
 * This is a sample Petstore server.  You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/). 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * Body1
 */


public class Body1 {
  @SerializedName("parrots")
  private List<AnyOfbody1ParrotsItems> parrots = null;

  public Body1 parrots(List<AnyOfbody1ParrotsItems> parrots) {
    this.parrots = parrots;
    return this;
  }

  public Body1 addParrotsItem(AnyOfbody1ParrotsItems parrotsItem) {
    if (this.parrots == null) {
      this.parrots = new ArrayList<AnyOfbody1ParrotsItems>();
    }
    this.parrots.add(parrotsItem);
    return this;
  }

   /**
   * Get parrots
   * @return parrots
  **/
  @Schema(description = "")
  public List<AnyOfbody1ParrotsItems> getParrots() {
    return parrots;
  }

  public void setParrots(List<AnyOfbody1ParrotsItems> parrots) {
    this.parrots = parrots;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Body1 body1 = (Body1) o;
    return Objects.equals(this.parrots, body1.parrots);
  }

  @Override
  public int hashCode() {
    return Objects.hash(parrots);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Body1 {\n");
    
    sb.append("    parrots: ").append(toIndentedString(parrots)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
