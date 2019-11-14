/**
 * Known Pose API
 * Define and retrieve (accurate) semantic poses in a 2D environment. This version is a workaround for some not yet available features of the OpenAPI Specification v3.0 (e.g. `anyOf` as a response type and adding a  `discriminator` for supporting polymorphism/composition). Therefore, ATM the sub-components BasicPose and InaccuratePose are reference objects inside their respective parent model.  
 *
 * OpenAPI spec version: 1.1.0
 * Contact: Kai.Waelti@dfki.de
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */import { InaccuratePose } from './inaccuratePose';


/**
 * Array containing matching poses
 */
export interface InaccuratePoseArray { 
    poseArray: Array<InaccuratePose>;
}