/**
 * NOTE: This class is auto generated by the swagger code generator program (3.0.30-SNAPSHOT).
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */
package io.swagger.api;

import io.swagger.model.Dog;
import io.swagger.v3.oas.annotations.Operation;
import io.swagger.v3.oas.annotations.Parameter;
import io.swagger.v3.oas.annotations.enums.ParameterIn;
import io.swagger.v3.oas.annotations.responses.ApiResponses;
import io.swagger.v3.oas.annotations.responses.ApiResponse;
import io.swagger.v3.oas.annotations.media.ArraySchema;
import io.swagger.v3.oas.annotations.media.Content;
import io.swagger.v3.oas.annotations.media.Schema;
import io.swagger.v3.oas.annotations.security.SecurityRequirement;
import org.springframework.http.ResponseEntity;
import org.springframework.validation.annotation.Validated;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestHeader;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RequestPart;
import org.springframework.web.multipart.MultipartFile;
import org.springframework.web.bind.annotation.CookieValue;

import javax.validation.Valid;
import javax.validation.constraints.*;
import java.util.List;
import java.util.Map;

@Validated
public interface DogApi {

    DogApiDelegate getDelegate();

    @Operation(summary = "Add a new dog to the store", description = "", tags={ "dog" })
    @ApiResponses(value = { 
        @ApiResponse(responseCode = "405", description = "Invalid input") })
    @RequestMapping(value = "/dog",
        consumes = { "application/json", "application/xml" }, 
        method = RequestMethod.POST)
    default ResponseEntity<Void> addDog(@Parameter(in = ParameterIn.DEFAULT, description = "Dog object that needs to be added to the store", required=true, schema=@Schema()) @Valid @RequestBody Dog body) {
        return getDelegate().addDog(body);
    }


    @Operation(summary = "Deletes a dog", description = "", tags={ "dog" })
    @ApiResponses(value = { 
        @ApiResponse(responseCode = "400", description = "Invalid dog value") })
    @RequestMapping(value = "/dog/{dogId}",
        method = RequestMethod.DELETE)
    default ResponseEntity<Void> deleteDog(@Parameter(in = ParameterIn.PATH, description = "Dog id to delete", required=true, schema=@Schema()) @PathVariable("dogId") Long dogId, @Parameter(in = ParameterIn.HEADER, description = "" ,schema=@Schema()) @RequestHeader(value="api_key", required=false) String apiKey) {
        return getDelegate().deleteDog(dogId, apiKey);
    }


    @Operation(summary = "Find dog by ID", description = "Returns a single dog", tags={ "dog" })
    @ApiResponses(value = { 
        @ApiResponse(responseCode = "200", description = "successful operation", content = @Content(mediaType = "application/xml", schema = @Schema(implementation = Dog.class))),
        
        @ApiResponse(responseCode = "400", description = "Invalid ID supplied"),
        
        @ApiResponse(responseCode = "404", description = "Pet not found") })
    @RequestMapping(value = "/dog/{dogId}",
        produces = { "application/xml", "application/json" }, 
        method = RequestMethod.GET)
    default ResponseEntity<Dog> getDogById(@Parameter(in = ParameterIn.PATH, description = "ID of dog to return", required=true, schema=@Schema()) @PathVariable("dogId") Long dogId) {
        return getDelegate().getDogById(dogId);
    }


    @Operation(summary = "Update an existing dog", description = "", tags={ "dog" })
    @ApiResponses(value = { 
        @ApiResponse(responseCode = "400", description = "Invalid ID supplied"),
        
        @ApiResponse(responseCode = "404", description = "Animal not found"),
        
        @ApiResponse(responseCode = "405", description = "Validation exception") })
    @RequestMapping(value = "/dog",
        consumes = { "application/json", "application/xml" }, 
        method = RequestMethod.PUT)
    default ResponseEntity<Void> updateDog(@Parameter(in = ParameterIn.DEFAULT, description = "Dog object that needs to be added.", required=true, schema=@Schema()) @Valid @RequestBody Dog body) {
        return getDelegate().updateDog(body);
    }


    @Operation(summary = "Updates a dog", description = "", tags={ "dog" })
    @ApiResponses(value = { 
        @ApiResponse(responseCode = "405", description = "Invalid input") })
    @RequestMapping(value = "/dog/{dogId}",
        consumes = { "application/x-www-form-urlencoded" }, 
        method = RequestMethod.POST)
    default ResponseEntity<Void> updateDogWithForm(@Parameter(in = ParameterIn.PATH, description = "ID of dog that needs to be updated", required=true, schema=@Schema()) @PathVariable("dogId") Long dogId, @Parameter(in = ParameterIn.DEFAULT, description = "",schema=@Schema()) @RequestParam(value="name", required=false)  String name, @Parameter(in = ParameterIn.DEFAULT, description = "",schema=@Schema()) @RequestParam(value="status", required=false)  String status) {
        return getDelegate().updateDogWithForm(dogId, name, status);
    }

}

